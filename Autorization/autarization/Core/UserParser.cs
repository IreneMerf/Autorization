using Autorization.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autarization.Core
{

    public static class UserParser
    {
        public static IEnumerable<User> ParseFile (string path)
        {
            foreach (string line in File.ReadAllLines("users2.txt").Skip(1))
            {
                string[] props = line.Split(';');

                yield return new User(Convert.ToInt32(props[0]), props[1], props[2], props[3],
                    Convert.ToDateTime(props[4]), Convert.ToDecimal(props[5]));
            }
        }

    }
    
}
