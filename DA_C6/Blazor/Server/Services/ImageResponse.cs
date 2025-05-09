﻿using Microsoft.AspNetCore.Mvc;
using Blazor.Server.Data;
using Blazor.Shared.Model;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Server.Services
{
    public class ImageResponse : IImage
    {
       private readonly ApplicationDbContext context;
        private readonly IImage _imageService;
        public ImageResponse(ApplicationDbContext ct) => context = ct;
        
		public IEnumerable<ImageDetails> GetImages(int productId)
		{
			return context.ImageDetails.Where(x => x.IDProduct == productId);
		}
        public ImageDetails AddImage( ImageDetails image)
        {
            context.ImageDetails.Add(image);
            context.SaveChanges();          
            return image;
        }

        public ImageDetails DeleteImage(int id)
        {
            var image = context.ImageDetails.FirstOrDefault(img => img.IDImage == id);

            if (image == null)
            {
                return null;
            }

            context.ImageDetails.Remove(image);
            context.SaveChanges();

            return image;
        }
    }
}
