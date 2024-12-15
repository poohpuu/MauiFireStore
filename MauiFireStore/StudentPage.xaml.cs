using MauiFireStore.services;
using MauiFireStore.ViewModels;

namespace MauiFireStore;

public partial class StudentPage : ContentPage
{
    public StudentPage()
    {
        InitializeComponent();

        var firestoreService = new FirestoreService();
        BindingContext = new StudentViewModel(firestoreService);
    }
}