using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    class Exam:IEnumerable
    {
        public Question[] Questions { get; set; }

        public IEnumerator GetEnumerator()
        {
            //return Questions.GetEnumerator();
            return new ExamEnumerator(Questions);

        }
    }

    class ExamEnumerator : IEnumerator
    {
        private Question[] questions;

        public ExamEnumerator(Question[] _questions)
        {
            questions = _questions;
        }

        private int currentIndex = -1;
        public object Current
        {
            get
            {
                return questions[currentIndex];
            }
        }

        public bool MoveNext()
        {
            currentIndex += 2;
            return currentIndex < questions.Length;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
