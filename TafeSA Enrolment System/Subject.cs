using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSA_Enrolment_System
{
    public class Subject
    {
        private string subjectCode;
        private string subjectName;
        private double cost;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="subjectCode"></param>
        /// <param name="subjectName"></param>
        /// <param name="cost"></param>
        public Subject(string subjectCode, string subjectName, int cost)
        {
            this.subjectCode = subjectCode;
            this.subjectName = subjectName;
            this.cost = cost;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Subject subject &&
                   subjectCode == subject.subjectCode &&
                   subjectName == subject.subjectName &&
                   cost == subject.cost;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                hash = hash * 23 + (subjectCode?.GetHashCode() ?? 0);
                hash = hash * 23 + (subjectName?.GetHashCode() ?? 0);
                hash = hash * 23 + cost.GetHashCode();
                return hash;
            }
        }

    }
}
