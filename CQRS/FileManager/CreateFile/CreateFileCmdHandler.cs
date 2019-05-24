using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KitcPPW.Data;
using KitcPPW.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace KitcPPW.CQRS.FileManager.CreateFile
{
    public class CreateFileCmdHandler:IRequestHandler<CreateFileCmd,Models.FileManager>
    {
        public IConfiguration _configuration;
        public IMediator _mediator;
        public UserManager<ApplicationUser> _userManger;

        public CreateFileCmdHandler(IMediator mediator, IConfiguration configuration,
            UserManager<ApplicationUser> userManger)
        {
            _mediator = mediator;
            _configuration = configuration;
            _userManger = userManger;
        }

        public async Task<Models.FileManager> Handle(CreateFileCmd request, CancellationToken cancellationToken)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            var context = new ApplicationDbContext(optionsBuilder.Options);

            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    
                    if (!(request.File == null || request.File.Length == 0))
                    {

                        #region Add file information to DB file Manager

                        var fileManger = new Models.FileManager()
                        {
                            CreatedDateTime = DateTime.Now,
                            Altitude = request.Altitude,
                            FileSizeInKb = request.File.Length / 1024,
                            FileType = request.FileType,
                            Lat = request.Lat,
                            Lng = request.Lng,
                            OriginalFileName = request.File.FileName,

                        };

                        context.Add(fileManger);
                        context.SaveChanges();

                        #endregion

                        #region Raw file copy to directory

                        long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

                        string extraPath = string.IsNullOrEmpty(request.ExtraPath) ? "" : "/"+request.ExtraPath;

                        var path = Path.Combine(
                            Directory.GetCurrentDirectory(), "wwwroot/Upload"+ extraPath,
                            milliseconds + "." + request.File.FileName.Split(".").AsQueryable().Last());

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await request.File.CopyToAsync(stream);
                        }

                        string file = milliseconds + "." + request.File.FileName.Split(".").AsQueryable().Last();
                        fileManger.FileName = file;

                        #endregion

                        #region commit and return file id

                        context.SaveChanges();
                        transaction.Commit();

                        return fileManger;

                        #endregion

                    }
                    

                    
                    
                }
                catch (Exception e)
                {
                    throw new Exception(e.ToString());
                }
            }


            return null;
        }
    }
}
