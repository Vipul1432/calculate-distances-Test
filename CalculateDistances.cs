using calculate_distances.Interfaces;
using Google.Cloud.Functions.Framework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace calculate_distances
{
    public class CalculateDistances : IHttpFunction
    {
        private readonly IDistanceCalculator _distanceCalculator;
        private readonly IFileProcessor _fileProcessor;
        private readonly IStorageService _storageService;
        private readonly IEmailService _emailService;

        public CalculateDistances(IDistanceCalculator distanceCalculator, IFileProcessor fileProcessor, IStorageService storageService, IEmailService emailService)
        {
            _distanceCalculator = distanceCalculator;
            _fileProcessor = fileProcessor;
            _storageService = storageService;
            _emailService = emailService;
        }

        public async Task HandleAsync(HttpContext context)
        {
            try
            {
                var processedFile = _fileProcessor.ProcessFile(context.Request.Body);
                var uploadedFile = _storageService.UploadFile(processedFile);
                _emailService.SendNotification(uploadedFile);
                context.Response.StatusCode = (int)HttpStatusCode.OK;
                await context.Response.WriteAsync("File processed, uploaded, and email sent successfully.");
            }
            catch (Exception ex)
            {
                // Log the error and return a meaningful response to the user
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                await context.Response.WriteAsync("An error occurred: " + ex.Message);
            }
        }
    }
}
