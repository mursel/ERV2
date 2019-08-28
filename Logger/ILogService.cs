using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public interface ILogService
    {
        void Err(string msg);
        void Info(string msg);
        void Dbg(string msg);
        void Warn(string msg);
    }
}
