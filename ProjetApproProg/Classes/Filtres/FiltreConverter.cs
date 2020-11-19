using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;

namespace ProjetApproProg
{
    public class FiltreConverter : CustomCreationConverter<Filtre> //JsonConverter
    {

        private int _objType;

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Filtre);
        }

        #region Overrides of JsonConverter

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken obj = JObject.ReadFrom(reader);
            _objType = obj["ObjType"].ToObject<int>();
            return base.ReadJson(obj.CreateReader(), objectType, existingValue, serializer);
        }

        public override Filtre Create(Type objectType)
        {
            switch (_objType)
            {
                case 0:
                    return new FiltreCondition();
                case 1:
                    return new FiltreNote();
                case 2:
                    return new FiltrePrix();
                default:
                    throw new NotImplementedException();
            }
        }

        #endregion
    }
}
