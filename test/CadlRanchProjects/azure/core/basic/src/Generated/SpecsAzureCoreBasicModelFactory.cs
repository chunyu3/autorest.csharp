// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace _Specs_.Azure.Core.Basic.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class SpecsAzureCoreBasicModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.User"/>. </summary>
        /// <param name="id"> The user's id. </param>
        /// <param name="name"> The user's name. </param>
        /// <param name="orders"> The user's order list. </param>
        /// <param name="etag"> The entity tag for this resource. </param>
        /// <returns> A new <see cref="Models.User"/> instance for mocking. </returns>
        public static User User(int id = default, string name = null, IEnumerable<UserOrder> orders = null, string etag = null)
        {
            orders ??= new List<UserOrder>();

            return new User(id, name, orders?.ToList(), etag);
        }

        /// <summary> Initializes a new instance of <see cref="Models.UserOrder"/>. </summary>
        /// <param name="id"> The user's id. </param>
        /// <param name="userId"> The user's id. </param>
        /// <param name="detail"> The user's order detail. </param>
        /// <returns> A new <see cref="Models.UserOrder"/> instance for mocking. </returns>
        public static UserOrder UserOrder(int id = default, int userId = default, string detail = null)
        {
            return new UserOrder(id, userId, detail);
        }

        /// <summary> Initializes a new instance of <see cref="Models.FirstItem"/>. </summary>
        /// <param name="id"> The id of the item. </param>
        /// <returns> A new <see cref="Models.FirstItem"/> instance for mocking. </returns>
        public static FirstItem FirstItem(int id = default)
        {
            return new FirstItem(id);
        }

        /// <summary> Initializes a new instance of <see cref="Models.SecondItem"/>. </summary>
        /// <param name="name"> The name of the item. </param>
        /// <returns> A new <see cref="Models.SecondItem"/> instance for mocking. </returns>
        public static SecondItem SecondItem(string name = null)
        {
            return new SecondItem(name);
        }
    }
}
