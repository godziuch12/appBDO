/* 
 * v1 Waste Register public Api
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing KeonApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class KeonApiTests
    {
        private KeonApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new KeonApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of KeonApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' KeonApi
            //Assert.IsInstanceOfType(typeof(KeonApi), instance, "instance is a KeonApi");
        }

        
        /// <summary>
        /// Test CreateKeon
        /// </summary>
        [Test]
        public void CreateKeonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1CreateKeonRequest request = null;
            //var response = instance.CreateKeon(request);
            //Assert.IsInstanceOf<WasteRegisterPublicApiApiModelsResponsesWasteRegisterHazardousWasteRecordCardV1KeonDto> (response, "response is WasteRegisterPublicApiApiModelsResponsesWasteRegisterHazardousWasteRecordCardV1KeonDto");
        }
        
        /// <summary>
        /// Test CreateKeonItem
        /// </summary>
        [Test]
        public void CreateKeonItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1CreateKeonItemRequest request = null;
            //var response = instance.CreateKeonItem(request);
            //Assert.IsInstanceOf<WasteRegisterPublicApiApiModelsResponsesWasteRegisterHazardousWasteRecordCardV1KeonItemDto> (response, "response is WasteRegisterPublicApiApiModelsResponsesWasteRegisterHazardousWasteRecordCardV1KeonItemDto");
        }
        
        /// <summary>
        /// Test DeleteKeon
        /// </summary>
        [Test]
        public void DeleteKeonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1DeleteKeonRequest request = null;
            //var response = instance.DeleteKeon(request);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DeleteKeonItem
        /// </summary>
        [Test]
        public void DeleteKeonItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1DeleteKeonItemRequest request = null;
            //var response = instance.DeleteKeonItem(request);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test EditKeonItem
        /// </summary>
        [Test]
        public void EditKeonItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1EditKeonItemRequest request = null;
            //var response = instance.EditKeonItem(request);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetKeon
        /// </summary>
        [Test]
        public void GetKeonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? keonId = null;
            //var response = instance.GetKeon(keonId);
            //Assert.IsInstanceOf<WasteRegisterPublicApiApiModelsResponsesWasteRegisterHazardousWasteRecordCardV1KeonDto> (response, "response is WasteRegisterPublicApiApiModelsResponsesWasteRegisterHazardousWasteRecordCardV1KeonDto");
        }
        
        /// <summary>
        /// Test GetKeonItem
        /// </summary>
        [Test]
        public void GetKeonItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? keonItemId = null;
            //var response = instance.GetKeonItem(keonItemId);
            //Assert.IsInstanceOf<WasteRegisterPublicApiApiModelsResponsesWasteRegisterHazardousWasteRecordCardV1KeonItemDto> (response, "response is WasteRegisterPublicApiApiModelsResponsesWasteRegisterHazardousWasteRecordCardV1KeonItemDto");
        }
        
        /// <summary>
        /// Test GetKeonPrintingPageData
        /// </summary>
        [Test]
        public void GetKeonPrintingPageDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? keonId = null;
            //var response = instance.GetKeonPrintingPageData(keonId);
            //Assert.IsInstanceOf<WasteRegisterPublicApiApiModelsResponsesWasteRegisterHazardousWasteRecordCardV1GetKeonPrintingPageDataResponse> (response, "response is WasteRegisterPublicApiApiModelsResponsesWasteRegisterHazardousWasteRecordCardV1GetKeonPrintingPageDataResponse");
        }
        
        /// <summary>
        /// Test GetKeonSummary
        /// </summary>
        [Test]
        public void GetKeonSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? keonId = null;
            //var response = instance.GetKeonSummary(keonId);
            //Assert.IsInstanceOf<WasteRegisterPublicApiApiModelsResponsesWasteRegisterHazardousWasteRecordCardV1GetKeonSummaryResponse> (response, "response is WasteRegisterPublicApiApiModelsResponsesWasteRegisterHazardousWasteRecordCardV1GetKeonSummaryResponse");
        }
        
        /// <summary>
        /// Test GetKeonWithKeonItems
        /// </summary>
        [Test]
        public void GetKeonWithKeonItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? keonId = null;
            //var response = instance.GetKeonWithKeonItems(keonId);
            //Assert.IsInstanceOf<WasteRegisterPublicApiApiModelsResponsesWasteRegisterHazardousWasteRecordCardV1GetKeonWithKeonItemsResponse> (response, "response is WasteRegisterPublicApiApiModelsResponsesWasteRegisterHazardousWasteRecordCardV1GetKeonWithKeonItemsResponse");
        }
        
        /// <summary>
        /// Test SearchKeon
        /// </summary>
        [Test]
        public void SearchKeonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1SearchKeonRequest request = null;
            //var response = instance.SearchKeon(request);
            //Assert.IsInstanceOf<WasteRegisterPublicApiApiModelsCollectionsPaginatedPage1WasteRegisterPublicApiApiModelsResponsesWasteRegisterHazardousWasteRecordCardV1SearchKeonResultDtoWasteRegisterPublicApiVersion1000CultureneutralPublicKeyTokennull> (response, "response is WasteRegisterPublicApiApiModelsCollectionsPaginatedPage1WasteRegisterPublicApiApiModelsResponsesWasteRegisterHazardousWasteRecordCardV1SearchKeonResultDtoWasteRegisterPublicApiVersion1000CultureneutralPublicKeyTokennull");
        }
        
        /// <summary>
        /// Test SearchKeonItems
        /// </summary>
        [Test]
        public void SearchKeonItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WasteRegisterPublicApiApiModelsRequestsWasteRegisterHazardousWasteRecordCardV1SearchKeonItemsRequest request = null;
            //var response = instance.SearchKeonItems(request);
            //Assert.IsInstanceOf<WasteRegisterPublicApiApiModelsCollectionsPaginatedPage1WasteRegisterPublicApiApiModelsResponsesWasteRegisterHazardousWasteRecordCardV1SearchKeonItemResultDtoWasteRegisterPublicApiVersion1000CultureneutralPublicKeyTokennull> (response, "response is WasteRegisterPublicApiApiModelsCollectionsPaginatedPage1WasteRegisterPublicApiApiModelsResponsesWasteRegisterHazardousWasteRecordCardV1SearchKeonItemResultDtoWasteRegisterPublicApiVersion1000CultureneutralPublicKeyTokennull");
        }
        
    }

}
