import axios from 'axios';

import arrow from '../../assets/images/arrow-up-right.svg';
import thumbnail from '../../assets/images/image.svg';
import deleteIcon from '../../assets/images/trash.png';

import HashMapsApi from 'https://cdn.jsdelivr.net/gh/readyyyk/randImgAPI-npm@main/HashMapsApi.js';

import './blog-card.styles.scss';

export default function BlogCard({ id, title, description }) {
  const handleDeleteClick = async id => {
    try {
      await axios.delete(`http://localhost:5267/api/Blogs/${id}`);
      const hashMapsApi = new HashMapsApi('https://readyyyk-randimg.fly.dev');
      console.log(hashMapsApi.getLink('picsum'));
    } catch {
      console.log('Error occured');
    }
  };

  return (
    <article key={id} className='blog-card'>
      <h2>Blog card</h2>
      <div className=''>
        <img src={thumbnail} alt='' />
      </div>
      <a href={`blogs/${id}`}>
        <span>{title}</span>
        <img src={arrow} alt='' />
      </a>
      <p>{description}</p>
      <div className='overlay' onClick={() => handleDeleteClick(id)}>
        <img src={deleteIcon} alt='' />
      </div>
    </article>
  );
}
