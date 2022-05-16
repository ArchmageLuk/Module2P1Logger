using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Result
    {
    public bool _status;
    public DateTime _time;
    public string? _type;
    public string? _message;

    public Result()
    {
        _status = true;
        _time = DateTime.UtcNow.AddHours(3);
    }
}
