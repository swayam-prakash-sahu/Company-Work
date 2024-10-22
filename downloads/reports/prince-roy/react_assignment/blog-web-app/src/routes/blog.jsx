import { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import axios from 'axios';

import leftArrow from '../assets/images/left-arrow.png';

import './blog.styles.scss';

import config from '../config';

export default function Blog() {
  const [blogDetails, setBlogDetails] = useState([]);
  const { blogId } = useParams();

  useEffect(() => {
    const getBlogAsync = async () => {
      try {
        const response = await axios.get(`http://localhost:5267/api/Blogs/${blogId}`, config);
        setBlogDetails(response.data);
      } catch (err) {
        console.log(err);
      }
    };

    getBlogAsync();
  }, []);

  return (
    <div className='blog-container'>
      <article>
        <h2>{blogDetails.title}</h2>
        <p>{blogDetails.description}</p>
      </article>

      <a href='/'>
        <img src={leftArrow} alt='' />
        Back to Home
      </a>
    </div>
  );
}
