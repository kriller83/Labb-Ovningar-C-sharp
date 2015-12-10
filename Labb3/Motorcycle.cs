using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    class Motorcycle
    {

        private string modelName;
        private Engine engine;

        public void SetModelMc(string modelName)
        {
            this.modelName = modelName;
        }
        public string GetModel()
        {
            return modelName;
        }

        public void SetEngine(Engine engine)
        {
            this.engine = engine;
        }
        public Engine GetEngine()
        {
            return engine;
        
    }
    }
}