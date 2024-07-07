import React, { useState } from 'react';
import axios from 'axios';

const AuthExample = () => {
  const [token, setToken] = useState(localStorage.getItem('token') || null);
  const [error, setError] = useState(null);
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const [isRegistering, setIsRegistering] = useState(false);

  const handleLogin = async (event) => {
    event.preventDefault();
    try {
      const response = await axios.post(
        'https://dummyjson.com/auth/login',
        {
          username,
          password
        }
      );
      const { token } = response.data;
      localStorage.setItem('token', token);
      setToken(token);
      setError(null);
      console.log('Login successful. Token:', token);
    } catch (error) {
      setError(error.message);
      console.error('Login error:', error.message);
    }
  };

  const handleRegister = async (event) => {
    event.preventDefault();
    try {
      const response = await axios.post(
        'https://dummyjson.com/auth/register',
        {
          username,
          password
        }
      );
      console.log('Registration successful:', response.data);
      await handleLogin(event);
    } catch (error) {
      setError(error.message);
      console.error('Registration error:', error.message);
    }
  };

  const handleLogout = () => {
    localStorage.removeItem('token');
    setToken(null);
    console.log('Logged out');
  };

  const toggleForm = () => {
    setIsRegistering(!isRegistering);
    setUsername('');
    setPassword('');
    setError(null);
  };

  return (
    <div>
      <h2>Authentication Example</h2>
      {token ? (
        <div>
          <p>Logged in! Token: {token}</p>
          <button onClick={handleLogout}>Logout</button>
        </div>
      ) : (
        <div>
          {isRegistering ? (
            <form onSubmit={handleRegister}>
              <h3>Registration</h3>
              <input
                type="text"
                placeholder="Username"
                value={username}
                onChange={(e) => setUsername(e.target.value)}
                required
              />
              <input
                type="password"
                placeholder="Password"
                value={password}
                onChange={(e) => setPassword(e.target.value)}
                required
              />
              <button type="submit">Register</button>
              <p>Already have an account? <button onClick={toggleForm}>Login</button></p>
            </form>
          ) : (
            <form onSubmit={handleLogin}>
              <h3>Login</h3>
              <input
                type="text"
                placeholder="Username"
                value={username}
                onChange={(e) => setUsername(e.target.value)}
                required
              />
              <input
                type="password"
                placeholder="Password"
                value={password}
                onChange={(e) => setPassword(e.target.value)}
                required
              />
              <button type="submit">Login</button>
              <p>Don't have an account? <button onClick={toggleForm}>Register</button></p>
            </form>
          )}
          {error && <p style={{ color: 'red' }}>{error}</p>}
        </div>
      )}
    </div>
  );
};

export default AuthExample;