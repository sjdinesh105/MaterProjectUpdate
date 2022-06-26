using Mater.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaterCore.WebApi.Builders.Interfaces
{
    public interface ICommentResponseBuilder
    {
        bool AddComment(Comment comment);
    }
}
