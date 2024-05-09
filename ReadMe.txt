This Project Demonstartes how to upload Image and save it's path to the database
In the user table we need imagePath nvarchar column
In the user model we need a string property named imageUrl
in the registration form we add two fields text readOnly for image url, 
And Button for upload.
on upload event we add a guid(unique string) to the 
filename so we don't save it again with the same name
After saving we update the image url to the User.ImageUrl property.

Wheneve we would like to show the image, We bind image source
to user.ImageUrl Property