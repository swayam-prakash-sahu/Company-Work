import React, { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';


const Blogs = () => {
    const { id } = useParams();
    const [blog, setBlog] = useState(null);
    const [isLoading, setIsLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        fetch(`https://localhost:7236/api/Blogs/${id}`)
            .then((response) => response.json())
            .then((data) => {
                setBlog(data);
                setIsLoading(false);
            })
            .catch((error) => {
                console.error('Error fetching blog:', error);
                setError(error);
                setIsLoading(false);
            });
    }, [id]);

    if (isLoading) return <div>Loading...</div>;
    if (error) return <div>Error: {error.message}</div>;

    return (
        <div style={{background: 'linear-gradient(90deg, rgb(9, 32, 63), rgb(83, 120, 149))'}}>
            <nav className="navbar navbar-expand-lg navbar-dark bg-black text-info">
                <div className="container">
                    <a className="navbar-brand" href="/">Blogs Website</a>
                    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className="collapse navbar-collapse" id="navbarNav">
                        <ul className="navbar-nav ms-auto">
                        <li className="nav-item">
                                <a className="nav-link" href="/"><button className="btn btn-outline-info"><i class="bi bi-house"></i></button></a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
            <div className="card mx-auto mt-5 text-light-emphasis border-info bg-black" style={{maxWidth:'95%', padding:'10px',background: 'linear-gradient(90deg, rgb(9, 32, 63), rgb(83, 120, 149))'}} >
    {blog && (
        <div className="text-light">
            <h2 className="justify-content-center">{blog.Title}</h2><hr/>
            <p>{blog.Description}</p>
        </div>
    )}
</div>

        </div>
    );
};

export default Blogs;
