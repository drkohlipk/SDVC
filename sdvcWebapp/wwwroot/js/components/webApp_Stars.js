import React from 'react';
import StarRatingComponent from 'react-star-rating-component';

function Stars(props) {
	return (
		<StarRatingComponent
			name="stars" /* name of the radio input, it is required */
			value={props.rating} /* number of selected icon (`0` - none, `1` - first) */
			starCount={5} /* number of icons in rating, default `5` */
			starColor='#ffb400' /* color of selected icons, default `#ffb400` */
			emptyStarColor='#333' /* color of non-selected icons, default `#333` */
			editing={false} /* is component available for editing, default `true` */
		/>
	);
}

module.exports = Stars;
