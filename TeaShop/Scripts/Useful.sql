select substring(ImageThumbnailUrl, 1, Len(ImageThumbnailUrl) - 4) + '-sm.jpg' from Teas;
update teas set ImageThumbnailUrl = substring(ImageThumbnailUrl, 1, Len(ImageThumbnailUrl) - 4) + '-sm.jpg';