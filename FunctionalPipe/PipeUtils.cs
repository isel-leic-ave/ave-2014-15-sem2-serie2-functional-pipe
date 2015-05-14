using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPipe
{
    public static class PipeUtils
    {
        /// <summary>
        /// Retorna uma nova instância de Func<T, Rafter> cuja execução é igual à
        /// chamada de self seguida de after.
        /// O resultado de self é passado como argumento a after.
        /// </summary>
        public static Func<T, Rafter> AndThen<T, Rself, Rafter>(
            this Func<T, Rself> self,
            Func<Rself, Rafter> after)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retorna uma nova instância de Func<T, T> cuja execução é igual à 
        /// chamada encadeada de todos os métodos estáticos compatíveis com 
        /// Func<T, T> do assembly localizado em path.
        /// Os métodos são encadeados através da função AndThen.
        /// </summary>
        public static Func<T, T> ChainMethods<T>(string path)
        {
            Assembly a = Assembly.LoadFrom(path);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Retorna uma nova instância de Func<T, T> cuja execução é igual à 
        /// chamada encadeada de todos os métodos estáticos compatíveis com 
        /// Func<T, T> do assembly localizado em path.
        /// Cada método é executado com o validador anotado, caso exista.
        /// </summary>
        public static Func<T, T> ChainMethodsValidators<T>(string path)
        {
            throw new NotImplementedException();
        }

    }
}
