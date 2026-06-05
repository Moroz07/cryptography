using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    public struct EvaluationResult
    {
        public int ScoreValue;
        public string ScoreLevel;
        public string Details;

        public EvaluationResult(int score, string level, string details)
        {
            ScoreValue = score;
            ScoreLevel = level;
            Details = details;
        }
    }
}