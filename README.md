# Lab 4 Demo

### DemoController

Simple examples of passing data from controller action methods to a view.

### ProductController

##### Simple MVC example

Model: Product.cs
Controller: ProductController.cs
Views: Index.cshtml, ProductList.cshtml Details.cshtml, AddProduct.cshtml

#### Model Binding

Route value: See `Details` method which uses `id` route parameter
Query string: See `ProductList` method which passes a `searchTerm` string from a form on the view
Form values: See `AddProduct` method which passes a `Product` bound to data from a form on the view
