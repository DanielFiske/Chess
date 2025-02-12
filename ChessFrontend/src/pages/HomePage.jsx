import React from 'react';
import { Link } from 'react-router-dom';

function HomePage() {
  return (
    <div>
      <h1>Welcome to the Chess Game</h1>
      <Link to="/chess">Start Game</Link>
    </div>
  );
}

export default HomePage;