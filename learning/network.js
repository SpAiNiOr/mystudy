/*
var util = require('util');

var path = require('path');
var async = require('async');
var msRestAzure = require('ms-rest-azure');
var ComputeManagementClient = require('azure-arm-compute');
var StorageManagementClient = require('azure-arm-storage');
var NetworkManagementClient = require('azure-arm-network');
var ResourceManagementClient = require('azure-arm-resource').ResourceManagementClient;
var SubscriptionManagementClient = require('azure-arm-resource').SubscriptionClient;
 */
var msRestAzure = require('ms-rest-azure');
var NetworkManagementClient = require('azure-arm-network');
// var subscription-id = '3e8d1b7c-63d5-49c2-ad51-2be836910866'

/*//Environment Setup
_validateEnvironmentVariables();
var clientId = process.env['CLIENT_ID'];
var domain = process.env['DOMAIN'];
var subscriptionId = process.env['AZURE_SUBSCRIPTION_ID'];
var credentials = new msRestAzure.ApplicationTokenCredentials(clientId, domain, secret, { 'tokenCache': tokenCache });
*/
var user = 'bingshi@microsoft.com';
var pass = 'NEWBORN1!';


msRestAzure.interactiveLogin((err, credentials) => {
    if (err) throw err;

  networkclient = new NetworkManagementClient(credentials, '3e8d1b7c-63d5-49c2-ad51-2be836910866');
  //interface = new NetworkInterfaces(networkclient);
  networkclient.networkInterfaces.get('tmtst',"vminnew931").then(function (result) {
      console.log(result);
  });
});