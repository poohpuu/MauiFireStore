using MauiFireStore.services;
using MauiFireStore.ViewModels;

namespace MauiFireStore;

public partial class SamplePage : ContentPage
{
    public SamplePage()
    {
        //InitializeComponent();

        var firestoreService = new FirestoreService();
        BindingContext = new SampleViewModel(firestoreService);
    }
}