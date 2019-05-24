using System;
using System.Threading;
using System.Threading.Tasks;
using KitcPPW.CQRS.FileManager.CreateFile;
using KitcPPW.Data;
using KitcPPW.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace KitcPPW.CQRS.WorkOrder.AddPhoto
{
    public class AddPhotoCmdHandler : IRequestHandler<AddPhotoCmd, AddPhotoResponse>
    {
        public IConfiguration _configuration;
        public IMediator _mediator;
        public UserManager<ApplicationUser> _userManger;

        public AddPhotoCmdHandler(IMediator mediator, IConfiguration configuration,
            UserManager<ApplicationUser> userManger)
        {
            _mediator = mediator;
            _configuration = configuration;
            _userManger = userManger;
        }

        public Task<AddPhotoResponse> Handle(AddPhotoCmd request, CancellationToken cancellationToken)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            var context = new ApplicationDbContext(optionsBuilder.Options);

            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    var cmd = new CreateFileCmd()
                    {

                    };









                    transaction.Commit();
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