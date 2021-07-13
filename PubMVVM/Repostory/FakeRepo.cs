using PubMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubMVVM.Repostory
{
    public class FakeRepo
    {
        public List<Pub> GetAll()
        {
            return new List<Pub>
            {
                new Pub
                {
                    Name="NZS",
                    Price=1,
                    Volume=0.4
                },
                new Pub
                {
                    Name="Blanche",
                    Price=7,
                    Volume=0.4
                },
                new Pub
                {
                    Name="Erdinger",
                    Price=7,
                    Volume=0.5
                },
                new Pub
                {
                    Name="Salyan",
                    Price=1,
                    Volume=0.4
                }
            };
        }
    }
}
