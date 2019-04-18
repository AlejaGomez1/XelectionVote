namespace XelectionVote.App.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;
    using Common.Models;
    using Common.Services;
    public class EventsViewModel : BaseViewModel
    {

        private readonly ApiService apiService;
        private ObservableCollection<Event> events;

        public ObservableCollection<Event> Events
        {
           get { return this.events; }
           set { this.SetValue(ref this.events, value); }
        }


    public EventsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadEvents();
        }

        private async void LoadEvents()
        {
            var response = await this.apiService.GetListAsync<Event>(
                "https://xelectionvote.azurewebsites.net",
                "/api",
                "/Events");

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Accept");
                return;
            }
            var myEvents = (List<Event>)response.Result;
            this.Events = new ObservableCollection<Event>(myEvents);
        }
    }
}

