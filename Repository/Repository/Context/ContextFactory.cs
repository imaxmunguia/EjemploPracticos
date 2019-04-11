using System;
using System.Collections.Concurrent;
using System.Threading;

namespace Repository.Context
{
    public class ContextFactory
    {
        private static ConcurrentDictionary<string, SchoolEntities> contextStore;
        static ContextFactory()
        {
            contextStore = new ConcurrentDictionary<string, SchoolEntities>();
        }
        public static SchoolEntities Context { get; set; }
        public static SchoolEntities GetContext()
        {
            return Context ?? contextStore.GetOrAdd(Thread.CurrentThread.ManagedThreadId.ToString(),
                                                    x => 
                                                    {
                                                        throw new InvalidOperationException("You should use StartConnection Method before calling GetContext() Method.");
                                                    });
        }
        public static void OpenConnection()
        {
            contextStore.GetOrAdd(Thread.CurrentThread.ManagedThreadId.ToString(),
                                  x => new SchoolEntities());
        }
        public static void CloseConnection()
        {
            SchoolEntities entitiesElement;
            contextStore.TryRemove(Thread.CurrentThread.ManagedThreadId.ToString(), out entitiesElement);
            if (entitiesElement != null)
            {
                entitiesElement.Dispose();
            }
        }
    }
}