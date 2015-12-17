using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6_Casting_och_Override
{
    class Literals
    {
        float floatNumber = 23.89f;  //f
        long longNumber = 65974678596;  //Kan gå lika långt minus som plus
        char myCharacter = 'b';   //enkelfnutt til char
        string myString = "en sträng";  //sträng
        ulong manyNumbers = 1867496584758497878; //börjar från noll

        public override string ToString() => $"floatnumber: {floatNumber} \r\nlongnumber: {longNumber}\r\nmycharacter: {myCharacter}\r\nmystring: {myString}\r\nmanynumbers: {manyNumbers}";
    }
}
