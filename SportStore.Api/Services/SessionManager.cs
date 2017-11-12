using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.Api.Services
{
    public class SessionManager : ISessionManager
    {
        private readonly HttpSessionStateBase _session;

        public SessionManager(HttpSessionStateBase session)
        {
            _session = session;
        }

        public void Abandon()
        {
            _session.Abandon();
        }

        public T Get<T>(string key)
        {
            return (T)_session[key];
        }

        public T Get<T>(string key, Func<T> createDefault)
        {
            T retval;

            if (_session[key] != null && _session[key].GetType() == typeof(T))
            {
                retval = (T)_session[key];
            }
            else
            {
                retval = createDefault();
                _session[key] = retval;
            }

            return retval;
        }

        public void Set<T>(string name, T Value)
        {
            _session[name] = Value;
        }

        public T TryGet<T>(string key)
        {
            try
            {
                return (T)_session[key];
            }
            catch (NullReferenceException)
            {
                return default(T);
            }
        }
    }
}