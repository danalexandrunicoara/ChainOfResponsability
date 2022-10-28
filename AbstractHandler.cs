using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsability.Interfaces;

namespace ChainOfResponsability.Handlers
{
    public class AbstractHandler : IHandler
    {
        private IHandler _handler;
        public virtual object? Handle(object request)
        {
            if (request != null)
            {
                return _handler.Handle(request);
            }
            return null;
        }

        public IHandler SetNext(IHandler handler)
        {
            _handler = handler;
            return handler;
        }
    }
}
