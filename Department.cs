using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    internal class Department
    {
        public int idDepartment {  get; set; }
        public string nameBossDepartnemt { get; set; }
        public int idDirector {  get; set; }

        /// <summary>
        /// Конструктор департамента
        /// </summary>
        /// <param name="idDepartment">айди департамента</param>
        /// <param name="nameBossDepartment">имя руководителя департамента</param>
        /// <param name="idDirector">айди руководителя департамента</param>
        public Department(int idDepartment, string nameBossDepartment, int idDirector)
        {
            this.idDepartment = idDepartment;
            this.nameBossDepartnemt = nameBossDepartment;
            this.idDirector = idDirector;  
        }
    }
}
