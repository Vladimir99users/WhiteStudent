using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IFixablePromt
{
    public string DontKnowMessage { get; }
    public string YouCantReading { get; }
    public string WillYouGuessMessage { get; }
    public string HIMessage { get; }
    public string NegativeAnswer { get; }
    public string CorrectAnswer { get;  }
    public string ColdMessage { get;  }
    public string WarmMessage { get; }
    public string BurningMessage { get;  }
}
