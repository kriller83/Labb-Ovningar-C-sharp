using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    public class Car
    {
        public int Model { get;  set; }
        private string model;
        private Engine engine;

        public void SetModel(string model)
        {
            
            this.model = model;
        }
        public string GetModel()
        {
            return model;
        }
       
        public void SetEngine(Engine myEngine)
        {
           engine = myEngine;
        }
        public Engine GetEngine()
        {
            return engine;
        }

    }
}

