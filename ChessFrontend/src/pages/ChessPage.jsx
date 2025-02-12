import React, { useState, useEffect } from 'react';

function ChessPage() {
  const [gameState, setGameState] = useState(null);

  useEffect(() => {
    // Fetch initial game state from the backend API
    fetch('https://localhost:5001/api/chess')
      .then((response) => response.json())
      .then((data) => setGameState(data));
  }, []);

  return (
    <div>
      <h1>Chess Game</h1>
      {/* Render chess game state here */}
    </div>
  );
}

export default ChessPage;