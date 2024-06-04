﻿using Domain.Entities;
using Domain.Entities.Classes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;

namespace Infrastructure.DataAcces
{
    public class MongoDBClassMap
    {
        public static void RegisterClassMaps()
        {
            BsonClassMap.RegisterClassMap<User>(cm =>
            {
                cm.AutoMap();
                cm.MapIdMember(x => x.Id)
                    .SetIdGenerator(new StringObjectIdGenerator())
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));
            });

            BsonClassMap.RegisterClassMap<Questionnaire>();
            BsonClassMap.RegisterClassMap<QuestionnaireRun>();
            BsonClassMap.RegisterClassMap<QuestionnaireSubmit>();
        }
    }
}
