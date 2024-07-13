using System.Collections.Generic;
using BlazorShop.Models;

namespace BlazorShop.Services
{
    public class ProductService
    {
        private List<Product> products = new List<Product>
        {
            new Product { 
            Id = "bd2w",
            ImageUrl = "images/boss_bd-2w_001.jpg", 
            Title = "Boss BD-2W", 
            Description = "Premium overdrive pedal delivering classic blues tones with warm, tube-like overdrive and exceptional clarity.", 
            Price = 260
            },

        new Product { 
            Id = "dm2w",
            ImageUrl = "images/boss_dm-2w_001.jpg", 
            Title = "Boss DM-2W", 
            Description = "Modern reissue of the classic analog delay, offering warm delays up to 300ms in standard mode and cleaner, longer delays in custom mode.", 
            Price = 220
            },

        new Product { 
            Id = "sd1w",
            ImageUrl = "images/boss_sd-1w_001.jpg", 
            Title = "Boss SD-1W", 
            Description = "High-quality overdrive pedal combining the classic SD-1 sound with enhanced tonal options for smooth and dynamic overdrive.", 
            Price = 230 
            },

        new Product { 
            Id = "bp1w",
            ImageUrl = "images/boss-compact-wazacraft_bp1w_001.jpg", 
            Title = "Boss BP-1W", 
            Description = "High-quality bass preamp pedal offering rich, versatile tones with exceptional clarity and dynamic response.", 
            Price = 250
            },

        new Product { 
            Id = "dc2w",
            ImageUrl = "images/boss-compact-wazacraft_dc2w_001.jpg", 
            Title = "Boss DC-2W", 
            Description = "Stereo chorus pedal delivering lush, spatial effects with classic Dimension C sound and enhanced tonal options.", 
            Price = 330
            },
        
        new Product {
            Id = "ds1w",
            ImageUrl = "images/boss-compact-wazacraft_ds1w_001.jpg", 
            Title = "Boss DC-1W", 
            Description = "High-quality distortion pedal offering the classic DS-1 sound with enhanced tonal options and dynamic response.", 
            Price = 220
            },

        new Product { 
            Id = "fz1w",
            ImageUrl = "images/boss-compact-wazacraft_fz1w_001.jpg", 
            Title = "Boss FZ-1W", 
            Description = "Premium fuzz pedal delivering classic and modern fuzz tones with exceptional clarity and dynamic response.", 
            Price = 310
            },

        new Product { 
            Id = "hm2w",
            ImageUrl = "images/boss-compact-wazacraft_hm2w_001.jpg", 
            Title = "Boss HM-2W", 
            Description = "High-gain distortion pedal offering iconic heavy metal tones with enhanced versatility and control.", 
            Price = 210
            },

        new Product { 
            Id = "mt2w",
            ImageUrl = "images/boss-compact-wazacraft_mt2w_001.jpg", 
            Title = "Boss MT-2W", 
            Description = "High-gain distortion pedal providing aggressive, cutting tones with advanced tonal shaping capabilities.", 
            Price = 240
            },

        new Product { 
            Id = "tb2w",
            ImageUrl = "images/boss-compact-wazacraft_tb2w_001.jpg", 
            Title = "Boss TB-2W", 
            Description = "Authentic reproduction of the classic Tone Bender fuzz pedal with modern enhancements for improved performance.", 
            Price = 480
            },

        new Product { 
            Id = "ce2w",
            ImageUrl = "images/boss-waza_ce-2w_001.jpg", 
            Title = "Boss CE-2W", 
            Description = "Premium chorus pedal combining the classic CE-2 and CE-1 sounds with rich, warm modulation.", 
            Price = 315
            },

        new Product { 
            Id = "tu3w",
            ImageUrl = "images/boss-wazacraft_tu-3w_001.jpg", 
            Title = "Boss TU-3W", 
            Description = "High-precision tuner pedal offering enhanced accuracy, durability, and true bypass functionality.", 
            Price = 230
            },

        new Product { 
            Id = "vb2w",
            ImageUrl = "images/boss-wazacraft_vb-2w_001.jpg", 
            Title = "Boss VB-2W", 
            Description = "Premium vibrato pedal delivering lush, vintage vibrato effects with modern tonal enhancements.", 
            Price = 365
            },

        new Product {
            Id = "dd200",
            ImageUrl = "images/boss_200-dd200_001.jpg",
            Title = "Boss DD-200",
            Description = "Versatile delay pedal offering twelve distinct delay modes, advanced control options, and up to 10 seconds of delay time, ideal for a wide range of musical styles.",
            Price = 360
            },

        new Product {
            Id = "eq200",
            ImageUrl = "images/boss_200-eq200_001.jpg",
            Title = "Boss EQ-200",
            Description = "Powerful and compact graphic equalizer pedal with ten bands of EQ, stereo functionality, and detailed tone shaping capabilities for any setup.",
            Price = 360
            },

        new Product {
            Id = "md200",
            ImageUrl = "images/boss_200-md200_001.jpg",
            Title = "Boss MD-200",
            Description = "Versatile modulation pedal featuring twelve different modulation effects, deep control options, and high-quality sound for a wide range of musical styles.",
            Price = 360
            },
        
        new Product {
            Id = "od200",
            ImageUrl = "images/boss_200-od200_001.jpg",
            Title = "Boss OD-200",
            Description = "Advanced overdrive and distortion pedal combining multiple gain types, customizable controls, and hybrid analog/digital processing for a wide range of tones.",
            Price = 360
            },

        new Product {
            Id = "ir200",
            ImageUrl = "images/boss-200_ir200_001.jpg",
            Title = "Boss IR-200",
            Description = "High-quality amp and cabinet simulator pedal featuring advanced impulse response (IR) technology, multiple amp types, and extensive tone-shaping options for direct recording and live performance.",
            Price = 530
            },

        new Product {
            Id = "rc10r",
            ImageUrl = "images/boss-200_rc10r_001.jpg",
            Title = "Boss RC-10R",
            Description = "Compact looper pedal with integrated rhythm tracks, offering versatile looping capabilities, high-quality sound, and intuitive control for live performance and practice.",
            Price = 430
            },

        new Product {
            Id = "sy200",
            ImageUrl = "images/boss-200_sy200_001.jpg",
            Title = "Boss SY-200",
            Description = "Versatile synthesizer pedal offering a wide range of synth tones, advanced polyphony, and intuitive controls for seamless integration into any pedalboard setup.",
            Price = 430
            },
        
        new Product {
            Id = "dd500",
            ImageUrl = "images/boss_dd-500_001.jpg",
            Title = "Boss DD-500",
            Description = "Advanced digital delay pedal featuring twelve delay modes, extensive control options, and up to 10 seconds of delay time, providing exceptional versatility and high-quality sound.",
            Price = 550
            },

        new Product {
            Id = "md500",
            ImageUrl = "images/boss_md500_001.jpg",
            Title = "Boss MD-500",
            Description = "Premium modulation pedal with 28 different effects, extensive control options, and advanced digital processing for a wide array of high-quality modulation sounds.",
            Price = 550
            },

        new Product {
            Id = "rc500",
            ImageUrl = "images/boss_rc500_001.jpg",
            Title = "Boss RC-500",
            Description = "High-performance looper pedal with dual tracks, onboard rhythms, and extensive control features, designed for complex looping and creative performance.",
            Price = 520
            },

        new Product {
            Id = "rv500",
            ImageUrl = "images/boss_rv500_001.jpg",
            Title = "Boss RV-500",
            Description = "Advanced reverb pedal offering twelve different reverb modes, deep editing capabilities, and high-quality sound for versatile and immersive reverb effects.",
            Price = 550
            },
        
        new Product {
            Id = "ve500",
            ImageUrl = "images/boss_ve500_001.jpg",
            Title = "Boss VE-500",
            Description = "Comprehensive vocal effects processor with harmony, pitch correction, and looping capabilities, designed for enhancing live vocal performances with high-quality sound and versatile control options.",
            Price = 650
            },

        new Product {
            Id = "jb2",
            ImageUrl = "images/boss-compact_jb2_001.jpg",
            Title = "Boss JB-2",
            Description = "Collaborative overdrive pedal combining the sounds of Boss's BD-2 Blues Driver and JHS's Angry Charlie, offering a wide range of tonal options and versatile drive characteristics.",
            Price = 300
            },
        
        new Product {
            Id = "ad2",
            ImageUrl = "images/boss-compact_ad2_001.jpg",
            Title = "Boss AD-2",
            Description = "Acoustic preamp pedal providing natural-sounding tone enhancement, reverb, and feedback reduction for acoustic-electric guitars, ideal for live performance and recording.",
            Price = 170
            },
        
        new Product {
            Id = "ac2",
            ImageUrl = "images/boss_ac-2_001.jpg",
            Title = "Boss AC-2",
            Description = "Acoustic simulator pedal that transforms the sound of an electric guitar into realistic acoustic tones with simple controls for easy adjustment.",
            Price = 120
            },

        new Product {
            Id = "ac3",
            ImageUrl = "images/boss_ac-3_001.jpg",
            Title = "Boss AC-3",
            Description = "Acoustic simulator pedal that transforms the sound of an electric guitar into a variety of acoustic tones, offering easy control and realistic acoustic sound.",
            Price = 170
            }, 
        
        new Product {
            Id = "aw2",
            ImageUrl = "images/boss_aw-2_001.jpg",
            Title = "Boss AW-2",
            Description = "Dynamic auto wah pedal delivering responsive, touch-sensitive wah effects with adjustable sensitivity and depth for expressive guitar playing.",
            Price = 170
            },

        new Product {
            Id = "aw3",
            ImageUrl = "images/boss-compact_aw3_001.jpg",
            Title = "Boss AW-3",
            Description = "Advanced auto wah pedal offering a range of classic and modern wah effects, including touch-sensitive and tempo-based modulation, suitable for both guitar and bass.",
            Price = 170
            },

        new Product {
            Id = "bb1x",
            ImageUrl = "images/boss_bb-1x_001.jpg",
            Title = "Boss BB-1X",
            Description = "Premium bass driver pedal providing enhanced low-end clarity, dynamic response, and versatile tone shaping, ideal for both live performance and studio recording.",
            Price = 270
            },
        
        new Product {
            Id = "bc1x",
            ImageUrl = "images/boss-compact_bc-1x_001.jpg",
            Title = "Boss BC-1X",
            Description = "High-quality bass compressor pedal offering multiband compression, transparent sound, and advanced tone control for maintaining dynamics and clarity.",
            Price = 260
            },

        new Product {
            Id = "bc2",
            ImageUrl = "images/boss_bc-2_001.jpg",
            Title = "Boss BC-2",
            Description = "Versatile overdrive pedal delivering the sound and feel of classic British combo amplifiers, with responsive controls for a wide range of dynamic tones.",
            Price = 160
            },

        new Product {
            Id = "bd2",
            ImageUrl = "images/boss_bd-2_001.jpg",
            Title = "Boss BD-2",
            Description = "Classic overdrive pedal delivering warm, tube-like blues tones with smooth response and rich dynamics, ideal for a variety of musical styles.",
            Price = 160
            },

        new Product {
            Id = "bf2",
            ImageUrl = "images/boss_bf-2_001.jpg",
            Title = "Boss BF-2",
            Description = "Classic flanger pedal offering rich, versatile flanging effects with extensive control over depth, rate, manual, and resonance for a wide range of modulation sounds.",
            Price = 215
            },

        new Product {
            Id = "bf2b",
            ImageUrl = "images/boss_bf-2b_001.jpg",
            Title = "Boss BF-2B",
            Description = "Flanger pedal specifically designed for bass guitars, providing rich, swirling flanging effects with tailored low-end response and versatile control options.",
            Price = 110
            },
        
        new Product {
            Id = "bf3",
            ImageUrl = "images/boss_bf-3_001.jpg",
            Title = "Boss BF-3",
            Description = "Advanced flanger pedal with new Ultra and Gate/Pan modes, offering versatile flanging effects and stereo operation for both guitar and bass.",
            Price = 215
            },
        
        new Product {
            Id = "ce2",
            ImageUrl = "images/boss_ce-2_001.jpg",
            Title = "Boss CE-2",
            Description = "Classic chorus pedal known for its rich, warm modulation and lush, analog chorus effects, ideal for adding depth and dimension to your sound.",
            Price = 315
            },

        new Product {
            Id = "ce2b",
            ImageUrl = "images/boss_ce-2b_001.jpg",
            Title = "Boss CE-2B",
            Description = "Chorus pedal designed specifically for bass guitars, providing rich and warm chorus effects while maintaining low-end clarity and punch.",
            Price = 150
            },

        new Product {
            Id = "ce3",
            ImageUrl = "images/boss-compact_ce3_001.jpg",
            Title = "Boss CE-3",
            Description = "Stereo chorus pedal offering lush, versatile modulation effects with dual output for creating wide and immersive soundscapes.",
            Price = 120
            },

        new Product {
            Id = "ce5",
            ImageUrl = "images/boss_ce-5_001.jpg",
            Title = "Boss CE-5",
            Description = "Advanced chorus pedal delivering a wide range of chorus effects from vintage sounds to modern, clear modulation, with extensive control over high and low-frequency filters.",
            Price = 170
            },

        new Product {
            Id = "ceb3",
            ImageUrl = "images/boss_ceb-3_001.jpg",
            Title = "Boss CEB-3",
            Description = "Chorus pedal tailored for bass guitars, providing a rich, full chorus effect while preserving the clarity of the low frequencies.",
            Price = 200
            },

        new Product {
            Id = "dd3",
            ImageUrl = "images/boss_dd-3_001.jpg",
            Title = "Boss DD-3",
            Description = "Classic digital delay pedal offering crisp, clear delay effects with up to 800ms of delay time and straightforward controls for versatile use.",
            Price = 190
            },
        
        new Product {
            Id = "dd3t",
            ImageUrl = "images/boss-compact_dd3t_001.jpg",
            Title = "Boss DD3T",
            Description = "Updated version of the classic DD-3, featuring tap tempo functionality and enhanced delay time control, while maintaining the same crisp and clear digital delay effects.",
            Price = 210
            },

        new Product {
            Id = "dd5",
            ImageUrl = "images/boss_dd-5_001.jpg",
            Title = "Boss DD-5",
            Description = "Versatile digital delay pedal offering a range of delay times and modes, including reverse delay, with precise control and high-quality digital sound.",
            Price = 120
            },

        new Product {
            Id = "dd6",
            ImageUrl = "images/boss_dd-6_001.jpg",
            Title = "Boss DD-6",
            Description = "Advanced digital delay pedal with extended delay time, reverse delay, and tap tempo features, providing versatile and high-quality delay effects.",
            Price = 160
            },

        new Product {
            Id = "dd7",
            ImageUrl = "images/boss_dd-7_001.jpg",
            Title = "Boss DD-7",
            Description = "Feature-rich digital delay pedal offering expanded delay time, modulation delay, and analog delay modes, with external footswitch control for tap tempo and additional functionality.",
            Price = 140
            },

        new Product {
            Id = "dd8",
            ImageUrl = "images/boss_dd-8_001.jpg",
            Title = "Boss DD-8",
            Description = "Comprehensive digital delay pedal featuring diverse delay modes, stereo operation, and extensive control options, offering high-quality delay effects for any musical application.",
            Price = 260
            },

        new Product {
            Id = "ch1",
            ImageUrl = "images/boss_ch-1_001.jpg",
            Title = "Boss CH-1",
            Description = "Classic chorus pedal providing clean, shimmering chorus effects with adjustable EQ for precise tone shaping, ideal for both guitar and keyboard.",
            Price = 180
            },
        
        new Product {
            Id = "cp1x",
            ImageUrl = "images/boss-compact_cp1x_001.jpg",
            Title = "Boss CP-1X",
            Description = "Advanced compressor pedal utilizing multiband compression technology, delivering transparent and musical compression with detailed control and dynamic clarity.",
            Price = 250
            },

        new Product {
            Id = "cs3",
            ImageUrl = "images/boss_cs-3_001.jpg",
            Title = "Boss CS-3",
            Description = "Compression pedal offering smooth sustain, clear compression, and precise control over attack, tone, and level, ideal for enhancing overall guitar tone.",
            Price = 140
            },

        new Product {
            Id = "da2",
            ImageUrl = "images/boss_da-2_001.jpg",
            Title = "Boss DA-2",
            Description = "Innovative distortion pedal that adapts to your playing dynamics, providing responsive and articulate distortion tones with clear note definition.",
            Price = 140
            },
        };

        public List<Product> GetProducts()
        {
            return products;
        }

        public Product GetProductById(string id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
    }
}
