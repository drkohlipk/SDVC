import React from 'react';
import Suggestions from '../Keywords';
import FaSearch from 'react-icons/fa/search';
import Autosuggest from 'react-autosuggest';

// Teach Autosuggest how to calculate suggestions for any given input value.
function getSuggestions (value) {
	const inputValue = value.trim().toLowerCase();
	const inputLength = inputValue.length;

	return inputLength === 0 ? [] : Suggestions.filter(kw =>
		kw.text.toLowerCase().slice(0, inputLength) === inputValue
	);
};

// When suggestion is clicked, Autosuggest needs to populate the input element
// based on the clicked suggestion. Teach Autosuggest how to calculate the
// input value for every given suggestion.
const getSuggestionValue = suggestion => suggestion.text;

// Use your imagination to render suggestions.
const renderSuggestion = suggestion => (
	<div id="sugg">
		{suggestion.text}
	</div>
);

var Search_Container = React.createClass({
	getInitialState: function() {
		return {
			value: '',
      		suggestions: []
		};
	},

	onChange: function(event, { newValue }) {
		this.setState({
			value: newValue
		});
	},

	onSuggestionsFetchRequested: function({ value }) {
		this.setState({
			suggestions: getSuggestions(value)
		});
	},

	onSuggestionsClearRequested: function() {
		this.setState({
			suggestions: []
		});
	},

	onSuggestionSelected: function(event, { suggestion, suggestionValue, suggestionIndex, sectionIndex, method }) {
		this.props.getVSO();
	},
	
	render:	function() {
		const { value, suggestions } = this.state;
		const inputProps = {
			value,          // usually comes from the application state
			onChange: this.onChange,       // called every time the input value changes
			type: 'search',
			placeholder: 'Try searching instead'
		};

		function renderInputComponent(inputProps) {
			return(
				<div id="srchBox">
					<FaSearch id="srchI" size={23} color='#1d3666' />
					<input {...inputProps}/>
				</div>
			);
		};

		return (
			<Autosuggest
				suggestions={suggestions}
				onSuggestionsFetchRequested={this.onSuggestionsFetchRequested}
				onSuggestionsClearRequested={this.onSuggestionsClearRequested}
				onSuggestionSelected={this.onSuggestionSelected}
				getSuggestionValue={getSuggestionValue}
				renderSuggestion={renderSuggestion}
				renderInputComponent={renderInputComponent}
				inputProps={inputProps}
			/>
		);
	}
});

module.exports = Search_Container;