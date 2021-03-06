using System;
using MongoDB.Bson;

namespace PerformanceCounterCollect.Web.Models
{
	public interface IRepository : IDisposable
	{
		void Insert(string collectionName, BsonDocument item);
	    
		void CheckCollection(string collectionName, long collectionSize, long? collectionMaxItems, bool createIdField);
	}
}