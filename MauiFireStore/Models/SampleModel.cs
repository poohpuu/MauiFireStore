using Google.Cloud.Firestore;
namespace MauiFireStore.Models;


public class SampleModel
{

    [FirestoreProperty]
    public string Id { get; set; }


    [FirestoreProperty]
    public string Code { get; set; }


    [FirestoreProperty]
    public string Name { get; set; }


}