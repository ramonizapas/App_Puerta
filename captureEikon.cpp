Bitmap ^ CaptureEikon([Out]interior_ptr<String^> errmsg) {

	byte * capturedImage;
	capturedImage = (byte*)malloc(200000);
	int imageWidth, imageHeight;
	int errorCode;
	try {
		errorCode = EikonTouchLibrary::EikonTouchClass::CaptureImage(10000, &imageWidth, &imageHeight, capturedImage);

	}
	catch (Exception ^ e) {
		*errmsg = "Timeout";
		;		return nullptr;
	}
	auto imageArray = new Byte[imageWidth * imageHeight];
	if (errorCode == 0)
	{
		for (int i = 0; i < imageWidth * imageHeight; i++)
		{
			imageArray[i] = *(capturedImage + i);
		}
		Bitmap ^ bitmap = gcnew Bitmap(imageWidth, imageHeight);
		for (int i = 0; i < bitmap->Width; i++)
		{
			for (int j = 0; j < bitmap->Height; j++)
			{
				int colorval = imageArray[(j * imageWidth) + i];
				bitmap->SetPixel(i, j, Color::FromArgb(colorval, colorval, colorval));
			}
		}
		free(capturedImage);
		return bitmap;
	}
	else {
		*errmsg = "Unknown error";
		return nullptr;
	}
}