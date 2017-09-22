/// <reference path="../../assets/js/angular.js" />
/// <reference path="../app.module.js" />
/// <reference path="../app.Service.js" />
/// <reference path="../../assets/js/angular-route.js" />




angular.module('mainApp')
.controller('dashboardCtrl', function (SearchLead, $scope) {
   
    var vm = this;
    vm.title = "Test Lead search";
    vm.data = [];
    vm.productlist = [];
    vm.BuyerList = [];
    vm.websiteList = [];
    vm.leadStatus = [];

    vm.TotalLeads = [];
    vm.totalcount;
    vm.pageSize = 1;
    vm.pagecount = 0;
    vm.pages = [];
    vm.currentPage = 1;
    var index = 0;
    vm.pagedPost = [];
    vm.currentPost = null;
    vm.pageChange = pageChange;

    
    vm.clear = clear;

    function activate() {
        SearchLead.getlead().then(function (res) {
            vm.data = res.data;
            console.log("data", vm.data);
            vm.TotalLeads = vm.data.lead;
            console.log("Leads", vm.TotalLeads);

            vm.productlist = vm.data.ProductList;
            console.log("ProductList", vm.productlist);
            vm.BuyerList = vm.data.BuyerList;
            console.log("buyerlist", vm.BuyerList);
            vm.websiteList = vm.data.WebsiteList;
            console.log("websitelist", vm.websiteList);
            vm.leadStatus = vm.data.leadStatus;
            console.log("transferstatus", vm.leadStatus);

            vm.totalcount = vm.TotalLeads.length;
            console.log("totalleadcount", vm.totalcount);
            vm.pagecount = Math.ceil(vm.totalcount / vm.pageSize);
            console.log("pagecount", vm.pagecount);


            for (var i = 1; i <= vm.pagecount; i++) {
                vm.pages.push(i);
            }
            pageChange(vm.pages[--vm.currentPage]);

        });

    }
    activate();

    function pageChange(page) {
        console.log('the page pased is', page);
        vm.pagedPost = [];
        vm.currentPage = page;
        index = (page - 1) * vm.pageSize;
        console.log('the index is', index);
        var trackIndex = 0;
        for (var i = index; i <= vm.totalcount; i++) {
            vm.pagedPost.push(vm.TotalLeads[i]);
            trackIndex++;
            if (trackIndex == vm.pageSize) {
                break;
            }

        }

    }
    function clear() {
        
        var leadId = document.getElementById('leadId');
       
        leadId.value = '';

        var fullName = document.getElementById('fullName');
       
        fullName.value = '';

        var email = document.getElementById('email');

        email.value = '';

        var homePhone = document.getElementById('homePhone');
        homePhone.value = '';

        var websiteName = document.getElementById('websiteName');
       
        websiteName.selectedIndex = 0;

        var buyerName = document.getElementById("buyerName");
        buyerName.selectedIndex = 0;
        
        var dropDown = document.getElementById('leadStatus');
        dropDown.selectedIndex = 0;

        var product = document.getElementById('productid');
        product.selectedIndex = 0;
        
    }

    //$(function () {
    //    $("#trnsfrStart").datepicker();
    //    $("#trnsfrEnd").datepicker();
    //    $("#startDate").datepicker();
    //    $("#endDate").datepicker();
    //});
   
});


















        

    