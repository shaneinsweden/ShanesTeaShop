select substring(ImageThumbnailUrl, 1, Len(ImageThumbnailUrl) - 4) + '-sm.jpg' from Teas;
update teas set ImageThumbnailUrl = substring(ImageThumbnailUrl, 1, Len(ImageThumbnailUrl) - 4) + '-sm.jpg';

update teas set IsTeaOfTheWeek = 1 
where TeaId in (1, 3,6, 9, 11)