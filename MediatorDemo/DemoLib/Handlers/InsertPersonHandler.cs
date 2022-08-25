using DemoLib.Commands;
using DemoLib.DataAccess;
using DemoLib.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Handlers
{
	public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
	{
		private readonly IDataAccess _data;

		public InsertPersonHandler(IDataAccess data)
		{
			_data = data;
		}

		public async Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
		{
			return await Task.FromResult(_data.InsertPerson(request.FirstName,request.LastName));

		}
	}
}
