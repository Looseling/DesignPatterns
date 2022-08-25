using DemoLib.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Commands
{
	public record InsertPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;


	//public class InsertPersonCommandClass : IRequest<PersonModel>
	//{
	//	public string FirstName { get; set; }
	//	public string LastName{ get; set; }

	//	public InsertPersonCommandClass(string lastName, string firstName)
	//	{
	//		LastName = lastName;
	//		FirstName = firstName;
	//	}
	//}
}
