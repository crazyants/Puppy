﻿#region	License

//------------------------------------------------------------------------------------------------
// <Auto-generated>
//     <Author> Top Nguyen (http://topnguyen.net) </Author>
//     <Project> TopCore.Auth.Domain </Project>
//     <File> 
//         <Name> Entity.cs </Name>
//         <Created> 27 03 2017 02:39:27 PM </Created>
//         <Key> 9BBFB04B-177D-4D87-B047-2F94F957E579 </Key>
//     </File>
//     <Summary>
//         Entity is abstract entity to another entity inherit
//     </Summary>
// </Auto-generated>
//------------------------------------------------------------------------------------------------

#endregion License

using System;
using System.ComponentModel.DataAnnotations;
using Puppy.EF.Interfaces.Entity;

namespace Puppy.EF
{
    /// <summary>
    ///     Entity for Entity Framework
    /// </summary>
    /// <typeparam name="TKey">Id type of this entity</typeparam>
    public abstract class Entity<TKey> :
        ISoftDeletableEntity<TKey>,
        IAuditableEntity<TKey>,
        IVersionEntity,
        IGlobalIdentityEntity where TKey : struct
    {
        public virtual string GlobalId { get; set; } = Guid.NewGuid().ToString("N");

        [Key]
        public virtual TKey Id { get; set; }

        [Timestamp]
        public virtual byte[] Version { get; set; }


        // Create Info

        public virtual TKey? CreatedBy { get; set; }

        public virtual DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.UtcNow;

        // Update Info

        public virtual TKey? LastUpdatedBy { get; set; }

        public virtual DateTimeOffset? LastUpdatedTime { get; set; }

        // Delete Info

        public virtual bool IsDeleted { get; set; }

        public virtual TKey? DeletedBy { get; set; }

        public virtual DateTimeOffset? DeletedTime { get; set; }
    }

    public abstract class Entity : Entity<int>
    {
    }
}