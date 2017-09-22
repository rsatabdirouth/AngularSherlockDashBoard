/// <reference path="../assets/js/angular.js" />
/// <reference path="app.module.js" />


angular.module('mainApp')
.service('SearchLead', function ($http) {
    var service = this;
    service.getlead=getlead;
    function getlead(leadid,productName,email)
    {
        //return $http.get('http://localhost/ProjectOnSherlockAngular/api/lead/getleads');
        return $http.get("http://localhost/ProjectOnSherlockAngular/api/lead/getleads?leadId=" + leadId + "&productName=" + productName + "&email=" + email)
    }
   
    
});