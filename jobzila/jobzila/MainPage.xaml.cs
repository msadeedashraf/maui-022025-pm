using JobZila;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
namespace jobzila
{
    public partial class MainPage : ContentPage
    {


        public ObservableCollection<JobListing> Jobs { get; set; }

        public MainPage()
        {
            InitializeComponent();
            InitializeJobs();
            BindingContext = this;
        }

        private void InitializeJobs()
        {
            Jobs = new ObservableCollection<JobListing>
        {
            new JobListing
            {
                Title = "Software Engineer",
                Company = "CBC",
                Location = "New York, NY",
                Description = "We are looking for a skilled and experienced Software Developer to join our team. The ideal candidate should have strong programming skills in Java and experience with web development technologies such as HTML, CSS, and JavaScript. Familiarity with databases and version control systems is a plus."
            },
            new JobListing
            {
                Title = "Data Scientist",
                Company = "XYZ Corp.",
                Location = "San Francisco, CA",
                Description = "We are seeking a talented Data Scientist to analyze and interpret complex data sets. The successful candidate should have a strong background in statistical analysis, machine learning, and data visualization. Proficiency in programming languages such as Python and R is required."
            },
            // Add other job listings here
        };

            JobListings.ItemsSource = Jobs;


        }
    }
    /*
    private async void OnHomeClicked(object sender, EventArgs e)
    {
        // Navigate to home page
        await DisplayAlert("Navigation", "Navigate to Home", "OK");
    }
    
    private async void OnJobSearchClicked(object sender, EventArgs e)
    {
        // Navigate to job search page
        await DisplayAlert("Navigation", "Navigate to Job Search", "OK");
    }

    private async void OnJobListingClicked(object sender, EventArgs e)
    {
        // Refresh current page
        await DisplayAlert("Navigation", "Already on Job Listing page", "OK");
    }

    private async void OnContactClicked(object sender, EventArgs e)
    {
        // Navigate to contact page
        await DisplayAlert("Navigation", "Navigate to Contact", "OK");
    }

    private async void OnLearnMoreClicked(object sender, EventArgs e)
    {
        // Show job details
        await DisplayAlert("Job Details", "Show detailed job information", "OK");
    }
    */
}
