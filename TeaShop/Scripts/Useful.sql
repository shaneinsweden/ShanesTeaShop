select substring(ImageThumbnailUrl, 1, Len(ImageThumbnailUrl) - 4) + '-sm.jpg' from Teas;
update teas set ImageThumbnailUrl = substring(ImageThumbnailUrl, 1, Len(ImageThumbnailUrl) - 4) + '-sm.jpg';

update teas set IsTeaOfTheWeek = 1 
where TeaId in (1, 3,6, 9, 11)


insert into TeaReviews (TeaId, ReviewdBy, ReviewedOn, ReviewTitle, ReviewText, Rating)
values (1, 'shane', '2019-04-22 14:04:00', 'My favourite','What a <b>great</b> tea, I absolutely love this stuff. For breakfast or all day it truly is the best', 5)