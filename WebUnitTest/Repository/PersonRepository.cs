using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebUnitTest.Models;

namespace WebUnitTest.Repository
{
    public interface IPersonBuilderPersonRepository
    {
        PersonModel Get(int id);
    }

    public class PersonBuilderPersonRepository : IPersonBuilderPersonRepository
    {
        public PersonModel Get(int id)
        {
           return new PersonModel() {Name = "Fred Spiggott", Id = 1};


        }


    }
}