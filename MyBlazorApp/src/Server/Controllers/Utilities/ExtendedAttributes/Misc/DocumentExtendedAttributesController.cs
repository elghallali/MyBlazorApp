﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyBlazorApp.Application.Features.ExtendedAttributes.Commands.AddEdit;
using MyBlazorApp.Domain.Entities.ExtendedAttributes;
using MyBlazorApp.Domain.Entities.Misc;
using MyBlazorApp.Server.Controllers.Utilities.ExtendedAttributes.Base;
using MyBlazorApp.Shared.Constants.Permission;
using System.Threading.Tasks;

namespace MyBlazorApp.Server.Controllers.Utilities.ExtendedAttributes.Misc
{
    public class DocumentExtendedAttributesController : ExtendedAttributesController<int, int, Document, DocumentExtendedAttribute>
    {
        [Authorize(Policy = Permissions.DocumentExtendedAttributes.View)]
        public override Task<IActionResult> GetAll()
        {
            return base.GetAll();
        }

        [Authorize(Policy = Permissions.DocumentExtendedAttributes.View)]
        public override Task<IActionResult> GetAllByEntityId(int entityId)
        {
            return base.GetAllByEntityId(entityId);
        }

        [Authorize(Policy = Permissions.DocumentExtendedAttributes.View)]
        public override Task<IActionResult> GetById(int id)
        {
            return base.GetById(id);
        }

        [Authorize(Policy = Permissions.DocumentExtendedAttributes.Create)]
        public override Task<IActionResult> Post(AddEditExtendedAttributeCommand<int, int, Document, DocumentExtendedAttribute> command)
        {
            return base.Post(command);
        }

        [Authorize(Policy = Permissions.DocumentExtendedAttributes.Delete)]
        public override Task<IActionResult> Delete(int id)
        {
            return base.Delete(id);
        }

        [Authorize(Policy = Permissions.DocumentExtendedAttributes.Export)]
        public override Task<IActionResult> Export(string searchString = "", int entityId = default, bool includeEntity = false, bool onlyCurrentGroup = false, string currentGroup = "")
        {
            return base.Export(searchString, entityId, includeEntity, onlyCurrentGroup, currentGroup);
        }
    }
}