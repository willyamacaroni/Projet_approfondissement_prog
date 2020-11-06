using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace ProjetApproProg
{
    public class SiteConverter : CustomCreationConverter<Site> //JsonConverter
    {

        private int _objType;

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Site);
        }

        #region Overrides of JsonConverter

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken obj = JObject.ReadFrom(reader);
            _objType = obj["ObjType"].ToObject<int>();
            return base.ReadJson(obj.CreateReader(), objectType, existingValue, serializer);
        }

        public override Site Create(Type objectType)
        {
            switch (_objType)
            {
                case 0:
                    return new SiteAmazon();
                case 1:
                    return new SiteBestBuy();
                case 2:
                    return new SiteEbay();
                case 3:
                    return new SiteMike();
                case 4:
                    return new SiteNewEgg();
                case 5:
                    return new SiteWalmart();
                default:
                    throw new NotImplementedException();
            }
        }

        #endregion
    }
}
