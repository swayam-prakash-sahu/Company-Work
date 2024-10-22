import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Home from './components/Home';
import Blogs from './components/Blogs';
import NewBlog from './components/CreateBlog';

const App = () => {
    return (
        <Router>
            <Routes>
                <Route path="/" element={<Home />} />
                <Route path="/create" element={<NewBlog />} />
                <Route path="/blogs/:id" element={<Blogs />} />
            </Routes>
        </Router>
    );
};

export default App;
