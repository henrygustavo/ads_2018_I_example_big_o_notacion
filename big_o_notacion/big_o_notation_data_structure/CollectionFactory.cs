using System;
using System.Collections.Generic;

namespace big_o_notation_data_structure
{
    public class CollectionFactory
    {
        public static ICollection<String> getCollection(CollectionType collectionType)
        {
            switch (collectionType)
            {
                case CollectionType.ArrayList:
                    return new List<String>();
                case CollectionType.HashSet:
                    return new HashSet<String>();
                default:
                    return new HashSet<String>();
            }
        }
    }
}
