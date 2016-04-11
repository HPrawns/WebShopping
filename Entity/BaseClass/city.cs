using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.BaseClass
{
    [Serializable]
    public class city
    {

        private string id;
        [DataContextAttribute("Id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        [DataContextAttribute("Name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private string countrycode;
        [DataContextAttribute("Countrycode")]

        public string Countrycode
        {
            get { return countrycode; }
            set { countrycode = value; }
        }



        private string district;
        [DataContextAttribute("District")]
        public string District
        {
            get { return district; }
            set { district = value; }
        }


        private string population;
        [DataContextAttribute("Population")]
        public string Population
        {
            get { return population; }
            set { population = value; }
        }
    }
}
