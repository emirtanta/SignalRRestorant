using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.Api.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IMoneyCaseService _moneyCaseService;
        private readonly IMenuTableService _menuTableService;
        private readonly IBookingService _bookingService;
        private readonly INotificationService _notificationService;

        public SignalRHub(ICategoryService categoryService, IProductService productService,IOrderService orderService,IMoneyCaseService moneyCaseService, IMenuTableService menuTableService, IBookingService bookingService, INotificationService notificationService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _orderService = orderService;
            _moneyCaseService = moneyCaseService;
            _menuTableService = menuTableService;
            _bookingService = bookingService;
            _notificationService = notificationService;
        }

        #region ayrı ayrı istatistikleri getirmek için

        //public async Task SendCategoryCount() 
        //{
        //    var value= _categoryService.TCategoryCount();

        //    await Clients.All.SendAsync("ReceiveCategoryCount", value);
        //}

        //public async Task SendProductCount()
        //{
        //    var value2 = _productService.TProductCount();

        //    await Clients.All.SendAsync("ReceiveProductCount", value2);
        //}

        //public async Task ActivePassiveCategoryCount()
        //{
        //    var value3 = _categoryService.TActiveCategoryCount();
        //    var value4 = _categoryService.TPasiveCategoryCount();

        //    await Clients.All.SendAsync("ReceiveActiveCategoryCount", value3);
        //    await Clients.All.SendAsync("ActivePassiveCategoryCount", value4);
        //}

        #endregion

        #region tek bir metot üzerinden istatistikleri getirme işlemi

        public async Task SendStatistic()
        {
            var value = _categoryService.TCategoryCount();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);

            var value2 = _productService.TProductCount();
            await Clients.All.SendAsync("ReceiveProductCount", value2);

            var value3 = _categoryService.TActiveCategoryCount();
            await Clients.All.SendAsync("ReceiveActiveCategoryCount", value3);

            var value4 = _categoryService.TPasiveCategoryCount();
            await Clients.All.SendAsync("ActivePassiveCategoryCount", value4);

            //hamburger sayısı
            var value5 = _productService.TProductByCategoryNameHamburger();
            await Clients.All.SendAsync("ReceiveProductByCategoryNameHamburger", value5);

            //içecek kategorisindeki ürün sayısı
            var value6 = _productService.TProductByCategoryNameDrink();
            await Clients.All.SendAsync("ReceiveProductByCategoryNameDrink", value6);

            //ortalama ürün fiyat
            var value7 = _productService.TProductPriceAvg();
            await Clients.All.SendAsync("ReceiveProductPriceAvg", value7.ToString("0.00")+"₺");

            //en pahalı ürün adı
            var value8 = _productService.TProductNameByMaxPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMaxPrice", value8);

            //en ucuz ürün adı
            var value9 = _productService.TProductNameByMinPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMinPrice", value9);

            //ortalama hamburger fiyat
            var value10 = _productService.TProductAvgPriceByHamburger();
            await Clients.All.SendAsync("ReceiveProductAvgPriceByHamburger", value10.ToString("0.00") + "₺");

            //toplam sipariş sayısı
            var value11 = _orderService.TTotalOrderCount();
            await Clients.All.SendAsync("ReceiveTotalOrderCount", value11);

            //aktif sipariş sayısı
            var value12 = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", value12);

            //son sipariş tutarı
            var value13 = _orderService.TLastOrderPrice();
            await Clients.All.SendAsync("ReceiveLastOrderPrice", value13.ToString("0.00") + "₺");

            //kasadaki tutar
            var value14 = _moneyCaseService.TTotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value14.ToString("0.00") + "₺");

            //toplam masa sayısı
            var value16 = _menuTableService.TMenuTableCount();
            await Clients.All.SendAsync("ReceiveMenuTableCount", value16);
        }

        #endregion


        public async Task SendProgress()
        {
            //kasadaki toplam tutar
            var value = _moneyCaseService.TTotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value.ToString("0.00") + "₺");

            //aktif sipariş sayısı
            var value2 = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", value2);

            //toplam masa sayısı
            var value3 = _menuTableService.TMenuTableCount();
            await Clients.All.SendAsync("ReceiveMenuTableCount", value3);

            //ortalama ürün fiyat
            var value5 = _productService.TProductPriceAvg();
            await Clients.All.SendAsync("ReceiveProductPriceAvg", value5);

            //ortalama hamburger fiyatı ProductAvgPriceByHamburger
            var value6 = _productService.TProductAvgPriceByHamburger();
            await Clients.All.SendAsync("ReceiveProductAvgPriceByHamburger", value6);

            //kategorideki içecek sayısı ProductByCategoryNameDrink
            var value7 = _productService.TProductByCategoryNameDrink();
            await Clients.All.SendAsync("ReceiveProductByCategoryNameDrink", value7);

            //toplam sipariş sayısı 
            var value8 = _orderService.TTotalOrderCount();
            await Clients.All.SendAsync("ReceiveTotalOrderCount", value8);

            //toplam steak burger fiyatı 
            var value9 = _productService.TProductPriceBySteakBurger();
            await Clients.All.SendAsync("ReceiveProductPriceBySteakBurger", value9);
        }

        //rezervasyon listesini getirir
        public async Task GetBookingList()
        {
            var values = _bookingService.TGetListAll();

            await Clients.All.SendAsync("ReceiveBookingList", values);
        }

        //bildirimleri getirir
        public async Task SendNotification()
        {
            var value = _notificationService.TNotificationCountByStatusFalse();
            await Clients.All.SendAsync("ReceiveNotificationCountByStatusFalse", value);

            //durumu okunmamış olanları liste şeklinde getirir
            var notificationListByFalse = _notificationService.TGetAllNotificationByFalse();
            await Clients.All.SendAsync("ReceiveNotificationListByFalse", notificationListByFalse);
        }

        //anlık masa durumlarını getirir
        public async Task GetMenuTableStatus()
        {
            var value = _menuTableService.TGetListAll();

            await Clients.All.SendAsync("ReceiveGetMenuTableStatus", value);
        }

        //anlık mesajlaşma işlemi yapar
        public async Task SendMessage(string user,string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        #region client'e bağlı anlık kullanıcı sayısını getirme bölümü

        //client'ta bağlı kullanıcı sayısını getirir
        public static int clientCount { get; set; } = 0;
        public override async Task OnConnectedAsync()
        {
            clientCount++;

            await Clients.All.SendAsync("ReceiveClientCount", clientCount);

            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            clientCount--;

            await Clients.All.SendAsync("ReceiveClientCount", clientCount);

            await base.OnDisconnectedAsync(exception);
        }

        #endregion

    }
}
