import React from 'react';
import FaSearch from 'react-icons/fa/search';

function Search(props) {
	return (
		<div id="srchBox">
			<FaSearch id="srchI" size={23} color='#1d3666' />
			<input placeholder="Try searching instead"/>
		</div>
	);
}

module.exports = Search;
