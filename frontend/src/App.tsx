import React from 'react';
import './App.css';
import Header from './Header';
import BowlingList from './Bowling/BowlingList';

function App() {
  return (
    <div className="App">
      <Header title="This page gives a run down of the best Bowlers out there brought to you by Napster" />
      <BowlingList />
    </div>
  );
}

export default App;
