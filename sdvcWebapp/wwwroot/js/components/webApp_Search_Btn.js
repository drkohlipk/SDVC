import React from 'react';
import FaSearch from 'react-icons/fa/search';

function Search_Btn(props) {
	return (
		<div id="srchBox">
			<FaSearch id="srchI" size={30} color='#1d3666' />
			<input placeholder="Try searching instead."/>
		</div>
	);
}

module.exports = Search_Btn;
